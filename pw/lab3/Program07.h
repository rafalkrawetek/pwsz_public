const char NazwaProgramu[] = "Program07";
const int MaxX = 400;
const int MaxY = 300;
void Rysuj(HDC hdc, int x, int y, int size)
{
Ellipse(hdc, x-size, y-size, x+size, y+size);
}