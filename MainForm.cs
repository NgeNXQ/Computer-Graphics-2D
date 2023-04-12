using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FourthLabwork
{
    public partial class MainForm : Form
    {
        private readonly Timer timer;
        private readonly Bitmap bitmap;
        private readonly Random random;
        private readonly Graphics graphics;
        private readonly Queue<Keys> userInput;
        private readonly PictureBox movablePictureBox;
        private const int TICK_DELAY = 16;

        private const string OBSTACLE_SPRITE_PATH = "../../Resources/obstacle.png";
        private const string WHITE_CHARACTER_SPRITE_PATH = "../../Resources/white_character.png";
        private const string BLACK_CHARACTER_SPRITE_PATH = "../../Resources/black_character.png";

        private readonly Image obstacleSprite;
        private readonly Image whiteCharacterSprite;
        private readonly Image blackCharacterSprite;

        private readonly GameObject whiteCharacter;
        private readonly GameObject blackCharacter;
        private readonly GameObject leftBound;
        private readonly GameObject upperBound;
        private readonly GameObject rightBound;
        private readonly GameObject lowerBound;
        private readonly GameObject obstacleTop;
        private readonly GameObject obstacleLeft;
        private readonly GameObject obstacleRight;
        private readonly GameObject obstacleMiddle;
        private readonly GameObject obstacleMiddleOffset;

        private const int SPEED = 5;
        private const int BOUNCINESS = 0;
        private readonly Vector2 whiteSpawnPoint;
        private readonly Vector2 blackSpawnPoint;

        private Point startPoint;
        private bool autoMove = false;
        private bool dragging = false;
        private Vector2 movementVector;
        private GameObject activeCharacter;

        public MainForm()
        {
            InitializeComponent();
            timer = new Timer();
            this.DoubleBuffered = true;
            bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            graphics = Graphics.FromImage(bitmap);
            userInput = new Queue<Keys>();
            random = new Random();

            obstacleSprite = Image.FromFile(OBSTACLE_SPRITE_PATH);
            whiteCharacterSprite = Image.FromFile(WHITE_CHARACTER_SPRITE_PATH);
            blackCharacterSprite = Image.FromFile(BLACK_CHARACTER_SPRITE_PATH);

            blackSpawnPoint = new Vector2(400, 25);
            whiteSpawnPoint = new Vector2(400, 700);

            whiteCharacter = new GameObject(whiteSpawnPoint, whiteCharacterSprite);
            blackCharacter = new GameObject(blackSpawnPoint, blackCharacterSprite);
            obstacleTop = new GameObject(new Vector2(100, 100), obstacleSprite, 600, 10);
            obstacleLeft = new GameObject(new Vector2(100, 110), obstacleSprite, 10, 600);
            obstacleRight = new GameObject(new Vector2(700, 100), obstacleSprite, 10, 600);
            obstacleMiddle = new GameObject(new Vector2(400, 450), obstacleSprite, 75, 75);
            upperBound = new GameObject(new Vector2(0, 0), obstacleSprite, this.Width, 10);
            leftBound = new GameObject(new Vector2(0, 0), obstacleSprite, 10, this.Height);
            obstacleMiddleOffset = new GameObject(new Vector2(200, 200), obstacleSprite, 125, 125);
            lowerBound = new GameObject(new Vector2(0, this.Height - 49), obstacleSprite, this.Width, 10);
            rightBound = new GameObject(new Vector2(this.Width - 26, 0), obstacleSprite, 10, this.Height);

            activeCharacter = whiteCharacter;
            whiteCharacter.CollisionEnterEvent += CharactersCollidersIntersactionsEvent;
            blackCharacter.CollisionEnterEvent += CharactersCollidersIntersactionsEvent;

            movablePictureBox = new PictureBox();
            movablePictureBox.MouseUp += MovablePicture_MouseUp;
            movablePictureBox.MouseDown += MovablePicture_MouseDown;
            movablePictureBox.MouseMove += MovablePicture_MouseMove;
            movablePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            movablePictureBox.Location = new Point(200, 200);

            GameObject.GameObjects = new GameObject[] { whiteCharacter, blackCharacter, leftBound, upperBound, lowerBound, rightBound, obstacleTop, obstacleLeft, obstacleRight, obstacleMiddle, obstacleMiddleOffset };
        }

        private void CharactersCollidersIntersactionsEvent() 
        {
            if (!autoMove)
                activeCharacter.Position -= movementVector * BOUNCINESS;
            else
            {
                switch (random.Next(0, 2)) 
                {
                    case 0:
                        if (movementVector.X == 0)
                            movementVector.X = random.Next(0, 2) == 0 ? 1 : -1;
                        else
                            movementVector.X = -movementVector.X;
                        break;
                    case 1:
                        if (movementVector.Y == 0)
                            movementVector.Y = random.Next(0, 2) == 0 ? 1 : -1;
                        else
                            movementVector.Y = -movementVector.Y;
                        break;
                }

                activeCharacter.Position += movementVector;
            }
        } 

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            timer.Interval = TICK_DELAY;
            timer.Tick += GameLoop;
            timer.Start();
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) => userInput.Enqueue(e.KeyCode);

        private void GameLoop(object sender, EventArgs e)
        {
            GameLoopUpdate();
            Invalidate();
        }

        private void GameLoopUpdate()
        {
            if (!dragging)
            {
                if (autoMove)
                    activeCharacter.Position += movementVector;

                if (userInput.Count > 0)
                {
                    switch (userInput.Dequeue())
                    {
                        case Keys.W:
                            movementVector = Vector2.Up * SPEED;
                            break;
                        case Keys.S:
                            movementVector = Vector2.Down * SPEED;
                            break;
                        case Keys.A:
                            movementVector = Vector2.Left * SPEED;
                            break;
                        case Keys.D:
                            movementVector = Vector2.Right * SPEED;
                            break;
                        case Keys.Oemplus:
                            autoMove = !autoMove;
                            break;
                        case Keys.Tab:
                            {
                                if (autoMove)
                                    autoMove = false;

                                movementVector = Vector2.Zero;
                                activeCharacter = activeCharacter == whiteCharacter ? blackCharacter : whiteCharacter;
                            }
                            break;
                        case Keys.M:
                            {
                                dragging = true;
                                movementVector = Vector2.Zero;
                                movablePictureBox.Image = activeCharacter.Sprite;
                                movablePictureBox.SetBounds(activeCharacter.Position.X, activeCharacter.Position.Y, activeCharacter.BoxCollider.Width, activeCharacter.BoxCollider.Height);
                                activeCharacter.Active = false;
                                this.Controls.Add(movablePictureBox);
                            }
                            break;
                        default:
                            movementVector = Vector2.Zero;
                            break;
                    }

                    activeCharacter.Position += movementVector;
                }
            }  
        }

        private void MovablePicture_MouseDown(object sender, MouseEventArgs e) => startPoint = e.Location;

        private void MovablePicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                movablePictureBox.Left += e.X - startPoint.X;
                movablePictureBox.Top += e.Y - startPoint.Y;
            }
        }

        private void MovablePicture_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            activeCharacter.Position = new Vector2(movablePictureBox.Location.X, movablePictureBox.Location.Y);
            activeCharacter.Active = true;
            this.Controls.Remove(movablePictureBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics.Clear(this.BackColor);

            foreach (GameObject gameObject in GameObject.GameObjects)
            {
                if (gameObject.Active)
                    graphics.DrawImage(gameObject.Sprite, gameObject.Position.X, gameObject.Position.Y, gameObject.Sprite.Width, gameObject.Sprite.Height);
            }

            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
