#include <iostream>
using namespace std;
float pyramidvolume(float l, float h, float w, string unit)
{
    float volume = (l * h * w) / 3 ;

    if (unit == " meters ")
    {
        return volume;
    }
    else if (unit == " centimeters ")
    {
        return volume * 1000000;
    }
    else if (unit == " milimeters ")
    {
        return volume * 1000000000;
    }
    else if (unit == " kilometer ")
    {
        return volume / 1000000000;
    }
}
int main()
{
    int lenth, hight, width;
    cout << " enter lenth,hight,width( in meters ): " << endl;
    cin >> lenth >> hight >> width;
    string unit;
    cout << " enter output unit ( in meters,centimeters,milimeters,kilometer): ";
    cin >> unit;
    cout << pyramidvolume(lenth, hight, width, unit) << "cubic" << unit << " ; ";
    return 0;
}