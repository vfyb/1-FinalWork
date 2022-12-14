# 1-FinalWork

## Основной метод GetArrayThreeOrLessSymbols

В основоном методе нужно пройти по элементам изначального массива строк и, 
если встретить элемент *с длиной строки <= 3*, записать его в новый массив.

Для этого:
1. Сначала создается массив **с нулевой размерностью** (элементов с длиной строки <= 3 может и не быть).
2. Создается индекс для нового массива равным нулю.
3. Далее циклом проходим по изначальному массиву.
4. Если встречаем элемент с длинной строки <= 3 то:
* увеличиваем размер нового массива на 1;
* вносим значение в появившуюся ячейку нового массива найденое значение из изначального массива;
* увеличиваем индекс нового массива на единицу;
5. Возвращаем **итоговый массив**.

Этот метод в виде блок-схемы:

![Блок-схема GetArrayThreeOrLessSymbols](1-FinalWork.png)

## Метод для печати массива на консоль
Здесь просто реализуется метод чтобы в консоли массив выглядел так:

    [ elem1, elem2, ..., elem5 ]

## Тело программы
1. Создаем изначальный массив.
2. Создаем новый массив путем вызова __Основного метода__.
3. Печатаем оба массива на консоль с помошью Метода для печати.
4. The end.
