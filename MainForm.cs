namespace ConwaysGameOfLife
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            resolutionPb.Image = Image.FromFile(@"../../../images/resolution.png");
            densityPb.Image = Image.FromFile(@"../../../images/density.png");
            startPb.Image = Image.FromFile(@"../../../images/play-button.png");
            pausePb.Image = Image.FromFile(@"../../../images/pause.png");
            oneStepPb.Image = Image.FromFile(@"../../../images/p1lay.png");
            Icon = Icon.ExtractAssociatedIcon(@"../../../images/icon.ico");
            pausePb.Enabled = oneStepPb.Enabled = false;
        }

        readonly Dictionary<int, Brush> brushList = new()
        {
            [0] = Brushes.Chartreuse,
            [1] = Brushes.Cyan,
            [2] = Brushes.Crimson,
            [3] = Brushes.Yellow,
            [4] = Brushes.Magenta,
            [5] = Brushes.LimeGreen,
            [6] = Brushes.SpringGreen,
            [7] = Brushes.Fuchsia
        };

        GameOfLife game;
        Graphics graphics;
        int resolution;
        int color;
        readonly Random random = new();

        void StartGame()
        {
            pausePb.Enabled = oneStepPb.Enabled = true;
            color = random.Next(brushList.Count);
            resolution = resolutionTb.Value;

            game = new GameOfLife
            (
                rows: gameBoardPb.Height / resolution,
                cols: gameBoardPb.Width / resolution,
                density: densityTb.Minimum + densityTb.Maximum - densityTb.Value
            );

            gameBoardPb.Image = new Bitmap(gameBoardPb.Width, gameBoardPb.Height);
            graphics = Graphics.FromImage(gameBoardPb.Image);
            timer.Start();
        }

        void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            var current = game.GetCurrentGeneration();

            for (int x = 0; x < current.GetLength(0); x++)
            {
                for (int y = 0; y < current.GetLength(1); y++)
                {
                    if (current[x, y])
                    {
                        graphics.FillRectangle(brushList[color], x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }

            gameBoardPb.Refresh();
            game.NextGeneration();
        }

        private void GameBoardPb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer.Enabled)
                return;

            var location = new Point(e.Location.X / resolution, e.Location.Y / resolution);

            switch (e.Button)
            {
                case MouseButtons.Left:
                    game.AddCell(location);
                    break;
                case MouseButtons.Right:
                    game.RemoveCell(location);
                    break;
                case MouseButtons.Middle:
                    color = random.Next(brushList.Count);
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e) => DrawNextGeneration();

        private void StartPb_Click(object sender, EventArgs e) => StartGame();

        private void PausePb_Click(object sender, EventArgs e) => timer.Enabled = !timer.Enabled;

        private void OneStepPb_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            DrawNextGeneration();
        }
    }
}