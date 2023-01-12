 Console.Clear();
 int num = 5;
void NumCnt (int num)
        {
            if (num == 0) return;
            Console.Write("{0,2}",num);
            NumCnt (num - 1);
        }
        NumCnt(num);