# 📗: Game03 :: 두더지 잡기

## 기본 구성요소
pictureBox 1~9 :: emptyground (빈땅)으로 초기화 [기본값] <br>
remainSecond :: 게임시간 --> 60초 <br>

## 게임 진행상황
progressbar :: 남은 시간은 줄어들고, 게임 진행시간은 올라가는 방식으로 진행 <br>
clicked_score :: 각각의 두더지마다 Tag설정, 눌린 두더지의 점수는 ( +@! )로 전체 스코어 옆에 표시 <br>
total_score :: 전체 점수 (score += clickedscore) 형식으로 중첩해서 계산 <br>

- **생성 관련 (확인 및 정확도 체크)**
  - create_normal_mole :: 생성된 일반 두더지의 총합 <br>
  - clicked_normal_mole :: 생성된 일반 두더지 중, 클릭이 되서 점수화된 두더지만 포함 <br>
  - create_advanced_mole :: 생성된 고급 두더지의 총합 <br>
  - clicked_advanced_mole :: 생성된 고급 두더지 중, 클릭이 되서 점수화된 두더지만 포함 <br>

## 평균점수 도출 및 기준점 생성
