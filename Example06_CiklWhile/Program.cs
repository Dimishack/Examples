int xa = 1, xb = 1, xc = 80;
int ya = 1, yb = 30, yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine('+');
Console.SetCursorPosition(xb, yb);
Console.WriteLine('+');
Console.SetCursorPosition(xc, yc);
Console.WriteLine('+');
int x = xa, y = yc;
for(int i = 0; i<15000; i++){
    int want = new Random().Next(0,3);
    if (want == 0){
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }
    if (want == 1){
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }
    if (want == 2){
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine('+');
}
Console.SetCursorPosition(1, yc+1);