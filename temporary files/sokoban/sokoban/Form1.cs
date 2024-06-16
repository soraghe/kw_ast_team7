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
        private DateTime stageStartTime;
        private int totalScore;
        private bool[] stageCleared;
        private int[] remainingTimes;

        private bool isMainScreen = true;
        private Image mainScreenImage;

        
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
            if(isMainScreen)
            {
                Text = Title + "시작하려면 N키를 누르세요...";

            }
            else
            {
                Text = Title + $"{timeCount}/300초 남았습니다. 현재 점수 : {totalScore}";
                //sokoTimerLabel.Text = $"{timeCount}/300초 남았습니다.";
            }
        }

        private void StartTimer()
        {
            timeCount = 300;
            stageStartTime = DateTime.Now;
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
        private Stack<Tuple<int, int, int, int, int, int, Image>> undoStack = new Stack<Tuple<int, int, int, int, int, int, Image>>();
        private Stack<Tuple<int, int, int, int, int, int, Image>> redoStack = new Stack<Tuple<int, int, int, int, int, int, Image>>();

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

        int XBlockOld;
        int YBlockOld;

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
        int[] stageScores = { 0, 10, 15, 20, 25, 30 }; 


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

            mainScreenImage = new Bitmap(Properties.Resources.mainImage);
            stageCleared = new bool[stageScores.Length];
            remainingTimes = new int[stageScores.Length];

            for (int i = 0; i < stageCleared.Length; i++)
            {
                stageCleared[i] = false;
            }

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
            if(isMainScreen)
            {
                e.Graphics.DrawImage(mainScreenImage, 0, 0, ClientSize.Width, ClientSize.Height);
                return;
            }
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
                undoStack.Push(Tuple.Create(YWooniOld, XWooniOld, YWooni, XWooni, XWooni * 2 - XWooniOld, YWooni * 2 - YWooniOld, Wooni));
                MapReal[YWooni * 2 - YWooniOld][XWooni * 2 - XWooniOld] = 'B'; 
            }
            else
            {
                undoStack.Push(Tuple.Create(YWooniOld, XWooniOld, YWooni, XWooni, -1, -1, Wooni));
            }

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
            if(isMainScreen && e.KeyCode == Keys.N)
            {
                isMainScreen = false;
                Refresh();
                return;
            }
            if (e.KeyCode == Keys.N)
            {
                if (Stage < stageScores.Length-1)
                {
                    SaveRemainingTime();
                    Stage++;
                    LoadMap();
                }
                return;
            }
            if (e.KeyCode == Keys.P)
            {
                if (Stage > 0)
                {
                    SaveRemainingTime();
                    Stage--;
                    LoadMap();
                }
                return;
            }
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


                default:              // 나머지 키 입력 무시 
                    return;
            }
            Move();
            Refresh();  
            if (EndGame == true)  // 여기에 메인과 연결 예정
            {
                double elapsedTime = (DateTime.Now - stageStartTime).TotalSeconds; // 라운드를 완료하는 시간 측정
                double percentage = Math.Max(0, Math.Min(1, (300 - elapsedTime) / 300)); // 백분율 계산
                int stageScore = (int)(stageScores[Stage] * percentage); // 백분율을 바탕으로 점수 계산
                totalScore += stageScore; // 총점에 추가
                stageCleared[Stage] = true; // 현재 스테이지를 클리어로 표시
                remainingTimes[Stage] = timeCount; // 남은 시간을 저장
                MessageBox.Show($"라운드 완료! 획득 점수: {stageScore}, 총 점수: {totalScore}", "결과", MessageBoxButtons.OK);




                if (Stage < stageScores.Length - 1)
                {
                    Stage++;
                }
                else
                {
                    bool allCleared = stageCleared.Skip(1).All(cleared => cleared); // 첫 번째 스테이지 제외
                    if (!allCleared)
                    {
                        DialogResult result = MessageBox.Show("모든 라운드를 클리어하지 못했습니다. 게임을 끝낼까요?", "경고", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            double finalPercentage = (double)totalScore / stageScores.Skip(1).Sum() * 100; // 첫 번째 스테이지 제외하고 계산
                            MessageBox.Show($"고생하셨어요. 당신의 최종 점수는 {finalPercentage:F2}점입니다.", "최종 성적", MessageBoxButtons.OK);
                            Environment.Exit(0);
                        }
                        else
                        {
                            return; // 게임을 계속합니다.
                        }
                    }
                    else
                    {
                        double finalPercentage = (double)totalScore / stageScores.Skip(1).Sum() * 100; // 첫 번째 스테이지 제외하고 계산
                        MessageBox.Show($"고생하셨어요. 당신의 최종 점수는 {finalPercentage:F2}점입니다.", "최종 성적", MessageBoxButtons.OK);
                        Environment.Exit(0);
                    }
                }
                LoadMap();
            }

        }
        private void SaveRemainingTime()
        {
            remainingTimes[Stage] = timeCount;
        }

        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                var lastMove = undoStack.Pop();
                redoStack.Push(Tuple.Create(YWooni, XWooni, lastMove.Item1, lastMove.Item2, lastMove.Item3, lastMove.Item4, Wooni));

                MapReal[YWooni][XWooni] = Map[Stage, YWooni][XWooni] == '.' ? '.' : ' ';
                if (lastMove.Item5 != -1 && lastMove.Item6 != -1)
                {
                    MapReal[lastMove.Item3][lastMove.Item4] = 'B';
                    MapReal[lastMove.Item5][lastMove.Item6] = ' ';
                }
                YWooni = lastMove.Item1;
                XWooni = lastMove.Item2;
                Wooni = lastMove.Item7;
                MapReal[YWooni][XWooni] = '@';

                Refresh();

            }
        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                var nextMove = redoStack.Pop();
                undoStack.Push(Tuple.Create(YWooni, XWooni, nextMove.Item1, nextMove.Item2, nextMove.Item3, nextMove.Item4, Wooni));

                MapReal[YWooni][XWooni] = Map[Stage, YWooni][XWooni] == '.' ? '.' : ' ';
                if (nextMove.Item5 != -1 && nextMove.Item6 != -1)
                {
                    MapReal[nextMove.Item3][nextMove.Item4] = 'B';
                    MapReal[nextMove.Item5][nextMove.Item6] = ' ';
                }
                YWooni = nextMove.Item1;
                XWooni = nextMove.Item2;
                Wooni = nextMove.Item7;
                MapReal[YWooni][XWooni] = '@';

                Refresh();
            }
        }



        private void sokoTimerTick(object sender, EventArgs e)
        {
        }
    }
}