#include <cmath>
#include <iomanip>
#include <iostream>
using namespace std;

double f(double x)
{
    return pow(x, 2.0) - 3 +  pow(0.5, x);
}

double g(double x)
{
    return x + 0.5 * f(x);
}

int main()
{
    double x;
    double eps;
    cout << "Enter initial root value   : ";cin >> x;
    cout << "Enter error of calculation : ";cin >> eps;
    for (double iter = 1; eps < fabs(f(x)); iter = iter + 1)
    {
        system("cls");
        cout << "Iteration : " << setprecision(0) << iter << endl;
        cout << "x    = " << x << endl;
        cout << "g(x) = " << g(x) << endl;
        cout << "f(x) = " << f(x) << endl;
        x = g(x);
    }
    system("pause");
    return 0;
}