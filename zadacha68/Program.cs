Console.Clear();
int ChM = 3;
int ChN = 6;
int AKK (int ChM, int ChN)
{
    if (ChM == 0) return ChN + 1;
if (ChM != 0 && ChN == 0) return AKK(ChM - 1, 1);
if (ChM > 0 && ChN > 0) return AKK(ChM - 1, AKK(ChM, ChN - 1));
return AKK (ChM, ChN);
}
Console.WriteLine($"функция Аккермана для чисел {ChM} и {ChN} = {AKK(ChM, ChN)}");