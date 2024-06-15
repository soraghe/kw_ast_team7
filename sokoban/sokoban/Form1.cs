using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban
{
    
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer sokoTimer;
        private int timeCount;

        private void InitializesokoTimer()
        {
            sokoTimer = new System.Windows.Forms.Timer();
            sokoTimer.Interval = 1000;
            sokoTimer.Tick += new EventHandler(sokoTimer_Tick);
        }
        private void sokoTimer_Tick(object sender, EventArgs e)
        {
            if(timeCount>0)
            {
                timeCount--;
                UpdateTimerLabel();
            }
            else
            {
                sokoTimer.Stop();
                MessageBox.Show("예외 처리");
            }
        }

        private void UpdateTimerLabel()
        {
            Text = Title + $"{timeCount}/300초 남았습니다.";
            //sokoTimerLabel.Text = $"{timeCount}/300초 남았습니다.";
        }

        private void StartTimer()
        {
            timeCount = 300;
            UpdateTimerLabel() ;
            sokoTimer.Start();
        }
        private void PauseTimer()
        {
            sokoTimer.Stop();
        }
        private void ResumeTimer()
        {
            sokoTimer.Start();
        }
        private void EndTimer()
        {
            sokoTimer.Stop();
        }
        private Stack<Tuple<int, int, int, int, Image>> undoStack = new Stack<Tuple<int, int, int, int, Image>>();
        private Stack<Tuple<int, int, int, int, Image>> redoStack = new Stack<Tuple<int, int, int, int, Image>>();

        // undo, redo 구현 용 스택


        const int WTileSize = 16;
        const int HTileSize = 9;
        const string Title = "KWU 소코반 - I030-3-1234-01 : ";

        int Stage;
        bool EndGame;
        int keyCount;

        char finalGrade = 'A';
        int finalGradeNumber = 0; // 성적 처리에 사용예정 


        Image Wooni;
        Image WooniFront;
        Image WooniBack;
        Image WooniLeft;
        Image WooniRight;

        Image Dirt;
        Image DirtGrass;
        Image Road;
        Image Box;
        Image Dot;


        int WTile;  // 가로 타일
        int HTile;  // 세로 타일

        int XWooni;
        int YWooni;
        int XWooniOld;
        int YWooniOld;

        char[][] MapReal;

        string[,] Map = {
                                 { "^^^^^^^^^^^^^^^^",  //여기다가 스테이지 명 추가 할 예정 
                                   "################",
                                   "################",
                                   "################",
                                   "################",  // OT : 튜토리얼의 개념임. 
                                   "################",
                                   "###     B.  ####",  //16 * 9 
                                   "###   @     ####",
                                   "################"   // 여기에 스킵 버튼 누를것 : 점수제? 시간제? -> 시간 말고, 무빙 횟수에 따라서 차감하기로
                                }, 
                                 { "^^^^^^^^^^^^^^^^",   
                                   "#######  #######",
                                   "######    ######",
                                   "#####  # B######",
                                   "########  ######",  
                                   "########  ######",
                                   "####### B ######",    //1번째 과제 
                                   "##### @  . . ###",
                                   "################"   
                                }, 
                                  {
                                 "^^^^^^^^^^^^^^^^",
                                 "#####     #  ###",
                                 "####  #  B  B###",
                                 "###   ###    ###",
                                 "##   #### @B ###",
                                 "###   ###  #.###", // 2번째 
                                 "####   #   .####", //레벨 디자인 이유 : 바로 옆에 있는걸로 막으면 그대로 망함 / 위에껀 (경우에 따라서는 두번 ) 돌아서 가야함 
                                 "#####     .#####",
                                 "#######  #######"
                                },
                                 { "^^^^^^^^^^^^^^^^",
                                   "################",  
                                   "#####     ######",  
                                   "#####B##   #####",  
                                   "####  ####  ####",  
                                   "###   @  B  ####",  //생각보다 난도 있어서 중간으로 둘듯... 
                                   "### ..# BB  ####",  
                                   "####..#     ####",  
                                   "################"   
                                }, 
                                {
                                 "^^^^^^^^^^^^^^^^",  
                                 "####   #########",  
                                 "### B B#########",  
                                 "##  B B ########",  
                                 "## # ## ########",  
                                 "#  # ## ###  ..#",  //풀이법은 단순 노가다의 산물이므로 3차 과제로 적당한듯?  
                                 "# B B@       ..#",  
                                 "#        ##  ..#",  
                                 "################"   
                                },
                               {
                                 "^^^^^^^^^^^^^^^^",
                                 "#######   ######",
                                 "##  ###B  ######",
                                 "## BB         ##",
                                 "##    ##B B## ##",
                                 "#    ###   ##  #",
                                 "#    @ ######  #", // 고려했던것보다 어려워져서 순위 상승시키기로함
                                 "#       .....  #",
                                 "################"
                                }
                                };

        


        public Form1()
        {
            InitializeComponent();
            InitializesokoTimer();
            Text = Title;
            Stage = 0;


            WooniFront = new Bitmap(Properties.Resources.Woonimain); // 우니를 그리고 우니로 나머지 값 잡아줌 
            WTile = WooniFront.Width;   
            HTile = WooniFront.Height;  
            ClientSize = new Size(WTileSize * WTile, HTileSize * HTile);

            WooniBack = new Bitmap(Properties.Resources.Wooniback);
            WooniLeft = new Bitmap(Properties.Resources.Woonileft);
            WooniRight = new Bitmap(Properties.Resources.Wooniright); // 4방향 게임이므로 다행히 우니 앞 뒤 / 옆 *2로 땜빵 

            Dirt = new Bitmap(Properties.Resources.Dirtnew); // 배경 뭐로 하지 아아아아악 
            DirtGrass = new Bitmap(Properties.Resources.Dirtgrass);

            Road = new Bitmap(Properties.Resources.Road); // 지나다닐 길
            Box = new Bitmap(Properties.Resources.Kwangwoon); 
            Dot = new Bitmap(Properties.Resources.Kwangwoongrayscale);

            XWooni = 0;
            YWooni = 0;

            LoadMap();
        }

        private void LoadMap()
        {
            MapReal = new char[HTileSize][];    
            for (int i = 0; i < HTileSize; ++i)  
            {
                MapReal[i] = Map[Stage, i].ToCharArray();
            }
            keyCount = 0;  // 성적처리? 
            Wooni = WooniFront;
            StartTimer();
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            EndGame = true;  
            Image Temp = Dirt;
            for (int j = 0; j < HTileSize; ++j)
            {
                for (int i = 0; i < WTileSize; ++i)
                {
                    switch (MapReal[j][i])
                    {  
                        case '^':
                            Temp = DirtGrass;
                            break;
                        case '#':
                            Temp = Dirt;
                            break;
                        case 'B':
                            Temp = Box;
                            if ('.' != Map[Stage, j][i])   
                            {
                                EndGame = false;
                            }
                            break;
                        case '.':
                            Temp = Dot;
                            break;
                        case ' ':
                            Temp = Road;
                            break;
                        case '@':       
                            Temp = Wooni;
                            XWooni = i;
                            YWooni = j;
                            break;
                    }
                    e.Graphics.DrawImage(Temp, WTile * i, HTile * j);
                }
            }
           // Text = Title + (Stage + 1) + "]  [" + keyCount + "]";   
        }

        private void Move() 
        {
            if ('#' == MapReal[YWooni][XWooni] || '^' == MapReal[YWooni][XWooni])  // 모서리 조건
            {
                return;
            }
            else if ('B' == MapReal[YWooni][XWooni])  
            {
                if ('#' == MapReal[YWooni * 2 - YWooniOld][XWooni * 2 - XWooniOld] || '^' == MapReal[YWooni * 2 - YWooniOld][XWooni * 2 - XWooniOld]) 
                {
                    return;
                }
                if ('B' == MapReal[YWooni * 2 - YWooniOld][XWooni * 2 - XWooniOld]) 
                {
                    return;   
                }
                MapReal[YWooni * 2 - YWooniOld][XWooni * 2 - XWooniOld] = 'B'; 
            }

            undoStack.Push(Tuple.Create(YWooniOld, XWooniOld, YWooni, XWooni,Wooni));
            redoStack.Clear();

            if ('.' == Map[Stage, YWooniOld][XWooniOld])    
            {
                MapReal[YWooniOld][XWooniOld] = '.';    
            }
            else
            {
                MapReal[YWooniOld][XWooniOld] = ' ';
            }
            MapReal[YWooni][XWooni] = '@'; 

            ++keyCount;  

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)   
        {
            YWooniOld = YWooni;
            XWooniOld = XWooni;
            
            switch (e.KeyCode)
            {
                case Keys.F5:        //테스트용 
                    if (DialogResult.Yes == MessageBox.Show("다시 시작할까요?", "선택", MessageBoxButtons.YesNo))
                    {
                        LoadMap();
                    }
                    return;   
                case Keys.Left:
                    --XWooni;   
                    Wooni = WooniLeft;
                    break;
                case Keys.Right:
                    ++XWooni;
                    Wooni = WooniRight;
                    break;
                case Keys.Up:
                    --YWooni;
                    Wooni = WooniBack;
                    break;
                case Keys.Down:
                    ++YWooni;
                    Wooni = WooniFront;
                    break;
                case Keys.Z:
                    if (e.Control) Undo();
                    return;
                case Keys.Y:
                    if (e.Control) Redo();
                    return;


                    /* 언도 / 레도 구현해야함! 
                     * 
                     * 
                     */
                default:              // 나머지 키 입력 무시 
                    return;
            }
            Move();
            Refresh();  
            if (EndGame == true)  // 여기에 메인과 연결 예정
            {
                ++Stage; // OT + 1번째 과제 + 2번째 과제 + 중간고사 + 3번째 과제 + 기말고사, -> 포기하면 학점 깎인다. 걸린 시간에 따라서 0 부여 예정
                switch (Stage)
                {
                    case 1:
                        MessageBox.Show("1번째 과제단계로 갑니다.", "조교로부터의 메시지", MessageBoxButtons.OK);

                        MessageBox.Show("고생하셨어요. 당신의 최종 성적은 " + finalGrade + finalGradeNumber + "입니다.", "조교로부터의 메시지", MessageBoxButtons.OK);

                        break;
                    case 2:
                        MessageBox.Show("이제 2번째 과제단계로 갑니다.", "조교로부터의 메시지", MessageBoxButtons.OK);
                        break;

                    case 3:
                        MessageBox.Show("잘하셨어요. 중간고사를 치루어봅시다.", "조교로부터의 메시지", MessageBoxButtons.OK);
                        break;

                    case 4:
                        MessageBox.Show("어느덧 마지막 과제에요!", "조교로부터의 메시지", MessageBoxButtons.OK);
                        break;

                    case 5:
                        MessageBox.Show("대망의 기말고사입니다. 화이팅! ", "조교로부터의 메시지", MessageBoxButtons.OK);
                        break;
                }
                if (Stage == 6)   // 
                {
                    MessageBox.Show("고생하셨어요. 당신의 최종 성적은 "+ finalGrade + finalGradeNumber + "입니다.", "조교로부터의 메시지", MessageBoxButtons.OK); //메시지 세분화?
                    Environment.Exit(0);
                }
                
                LoadMap();

            }

        }

       private void Undo()
        {
            if (undoStack.Count > 0)
            {
                var lastMove = undoStack.Pop();
                redoStack.Push(Tuple.Create(lastMove.Item3, lastMove.Item4, YWooni, XWooni, Wooni));  // 현재 위치와 되돌릴 위치 저장

                MapReal[YWooni][XWooni] = Map[Stage, YWooni][XWooni] == '.' ? '.' : ' ';
                YWooni = lastMove.Item1;
                XWooni = lastMove.Item2;
                Wooni = lastMove.Item5;
                MapReal[YWooni][XWooni] = '@';

                Refresh();
            }
        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                var nextMove = redoStack.Pop();
                undoStack.Push(Tuple.Create(nextMove.Item3, nextMove.Item4, YWooni, XWooni, Wooni));  // 현재 위치와 되돌릴 위치 저장

                MapReal[YWooni][XWooni] = Map[Stage, YWooni][XWooni] == '.' ? '.' : ' ';
                YWooni = nextMove.Item1;
                XWooni = nextMove.Item2;
                Wooni = nextMove.Item5;
                MapReal[YWooni][XWooni] = '@';

                Refresh();
            }
        }



        private void sokoTimerTick(object sender, EventArgs e)
        {
        }
    }
}