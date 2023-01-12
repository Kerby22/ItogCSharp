int num = 5;//определяем первоначальное значение
void NumCnt (int num)
{Console.Write(num);
NumCnt (num - 1);
}
NumCnt(num);
