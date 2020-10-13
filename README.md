# mvvm 패턴을 사용한 환율계산기
---

## 설명
1. 사용자의 입력은 VIew를 통해 들어옵니다.
2. View에서 들어온 데이터는 VIewModel에 전달되며 ViewModel은 Model과의 데이터 교환을 합니다.(Model에서는 DB나 FILEIO처리 등 VIEW와 상관없는 로직을 처리하곤 합니다.)
3. 데이터 교환 이후 ViewModel에서 가공, 처리한후 Data Binding을 통해 View를 갱신합니다.

## 기능
> mvvm 패턴을 활용하여 환율계산을 해줌

## 코드가 설명된 블로그
> https://frozenpond.tistory.com/53
