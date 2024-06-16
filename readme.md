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

1> 두더지 생성 횟수 및 성공률

0초 ~ 30초:<br>
생성 횟수: 30초 동안 1초에 한 번씩, 총 30번<br>
총 두더지 수: 30 * 2 = 60 마리<br>
기대 성공률: 100%<br>

30초 ~ 45초:<br>
생성 횟수: 15초 동안 0.7초에 한 번씩, 총 15 / 0.7 ≈ 21.43번<br>
총 두더지 수: 21.43 * 2 ≈ 42.86 마리<br>
기대 성공률: 100%<br>

45초 ~ 60초:<br>
생성 횟수: 15초 동안 0.5초에 한 번씩, 총 15 / 0.5 = 30번<br>
총 두더지 수: 30 * 2 = 60 마리<br>
기대 성공률: 50%<br>

2> 두더지 출현 확률 및 점수<br>

일반 두더지: 80% 출현 확률, 클릭 성공 시 1점<br>
고급 두더지: 20% 출현 확률, 클릭 성공 시 3점<br><br>
평균 점수 기대값=(0.8×1)+(0.2×3)=0.8+0.6=1.4<br>

3> 각 구간별 점수 계산
0초 ~ 30초:<br>
총 두더지 수: 60 마리<br>
기대 성공률: 100%<br>
기대 성공 두더지 수: 60 * 1 = 60 마리<br>
총 기대 점수: 60 * 1.4 = 84점<br>

30초 ~ 45초:<br>
총 두더지 수: 42.86 마리<br>
기대 성공률: 100%<br>
기대 성공 두더지 수: 42.86 * 1 = 42.86 마리<br>
총 기대 점수: 42.86 * 1.4 = 60점<br>

45초 ~ 60초:<br>
총 두더지 수: 60 마리<br>
기대 성공률: 50%<br>
기대 성공 두더지 수: 60 * 0.5 = 30 마리<br>
총 기대 점수: 30 * 1.4 = 42점<br>


4> 전체 기대 점수 계산
총 기대 점수: 84+60+42=186

실질적인 점수 커트라인은 다음과 같습니다:

A: 167점 이상
B: 149점 ~ 166점
C: 130점 ~ 148점
D: 112점 ~ 129점
F: 111점 이하

100점 만점 기준으로 계산하려면, 획득 점수에 0.5376을 곱하면 해결됨 (100/186)
