# Programming_Intro_Test

Контрольная работа Святослава Сорокина по курсу "Введение в специальность / Разработчик" на GeekBrains
Название: Создание массива меньше 3-х лементов"
Описание: создаёт новый массив из элементов исходного массива, в которых есть 3 и менее символов".
Например: ["ads", "2", "пропаганда"] ---> ["ads", "2"]
Алгоритм:
Долго думал, как сделать за 1 проход, но моего интеллекта не хватило. Так как первый раз надо пройти по массиву и пересчитать к-во необходимых элементов, чтобы создать
целевой массив нужной длины.
В результате решил воспользоваться служебным массивом, в котором значение элемента TRUE будет соответствовать тому, что элемент удовлетворяет необходимому условию ( <=3 ).
Массив класса boolean не должен занимать много места, а проверка на ИСТИНА/ЛОЖЬ происходит максимально быстро.
