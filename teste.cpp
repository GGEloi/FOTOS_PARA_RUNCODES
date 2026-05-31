#include <iostream>
#include <iomanip>
#include <cmath>
#include <string>
using namespace std;

int main(){
string tel,p1,p2,p3;
cin >> tel;
p1=tel.substr(0,2);
p2=tel.substr(2,5);
p3=tel.substr(7,4);
cout<<"("<<p1<<") "<<p2<<"-"<<p3<<endl;
return 0;
}
