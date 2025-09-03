
#include <bits/stdc++.h>
#include <unistd.h>
#include <windows.h>
#include <stdio.h>
using namespace std;

void countdown()
{
  system("cls");
  string line5;
  ifstream file5("D:\\MongNhu\\source\\so5.txt");
  cout << "\n\n\n\n\n\n\n\n\n";
  while (!file5.eof())
  {
    getline(file5, line5);
    cout << "\t\t\t\t\t\t\t\t" << line5 << endl;
  }
  sleep(1);

  system("cls");
  string line4;
  ifstream file4("D:\\MongNhu\\source\\so4.txt");
  cout << "\n\n\n\n\n\n\n\n\n\n\n";
  while (!file4.eof())
  {
    getline(file4, line4);
    cout << "\t\t\t\t\t\t\t\t" << line4 << endl;
  }
  sleep(1);
  system("cls");
  string line3;
  ifstream file3("D:\\MongNhu\\source\\so3.txt");
  cout << "\n\n\n\n\n\n\n\n\n\n\n";
  while (!file3.eof())
  {
    getline(file3, line3);
    cout << "\t\t\t\t\t\t\t\t" << line3 << endl;
  }
  sleep(1);
  system("cls");
  string line2;
  ifstream file2("D:\\MongNhu\\source\\so2.txt");
  cout << "\n\n\n\n\n\n\n\n\n\n\n";
  while (!file2.eof())
  {
    getline(file2, line2);
    cout << "\t\t\t\t\t\t\t\t" << line2 << endl;
  }
  sleep(1);
  system("cls");
  string line1;
  ifstream file1("D:\\MongNhu\\source\\so1.txt");
  cout << "\n\n\n\n\n\n\n\n\n\n";
  while (!file1.eof())
  {
    getline(file1, line1);
    cout << "\t\t\t\t\t\t\t\t" << line1 << endl;
  }
  sleep(1);
}
void loading()
{
  char j = 177, k = 219;
  cout << '\n';
  cout << "\t\t\t\t\t\t\t\t\t\t\t\t\tloading..\n";
  cout << "\t\t\t\t\t\t\t\t\t\t\t\t";
  for (int i = 0; i < 24; i++)
  {
    cout << j;
  }
  cout << "\r";
  cout << "\t\t\t\t\t\t\t\t\t\t\t\t";
  for (int i = 0; i < 24; i++)
  {
    cout << k;
    Sleep(300);
  }
}
void picture()
{
  system("cls");
  string line;
  ifstream file("D:\\MongNhu\\source\\nnn.txt");
  while (!file.eof())
  {
    getline(file, line);
    cout << "\t\t\t\t" << line << endl;
    Sleep(60);
  }
}
void traloidung()
{
  cout << '\n';
  cout << "(*)"
       << " okay tinh iu <3"
       << "\n\n";
  sleep(3);
  cout << "(*)"
       << " nguoi gi dau vua..xinh dep..cute..thong minh..   "
       << "\n\n";
  sleep(5);
  cout << "(*)"
       << " hay don nhan mon qua chan thanh cua tui <3"
       << "\n\n";
  sleep(5);
  cout << "(*)"
       << "ngay bay gio :33";
  sleep(5);
  system("cls");
}
int main()
{
  system("cls");
  cout << "\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
  loading();

  system("cls");
  sleep(1);
  cout << '\n';
  cout << "(*)"
       << " hello"
       << "\n\n";
  sleep(2);
  cout << "(*)"
       << " a nhon xe o (^.^)"
       << "\n\n";
  sleep(2);
  cout << "(*)"
       << " tui la Diii so hieu 001"
       << "\n\n";
  sleep(3);
  cout << "(*)"
       << " nhan dip lan dau gap nhau "
       << "\n\n";
  sleep(3);
  cout << "(*)"
       << " tui co mot phan qua tang ban :33"
       << "\n\n";
  sleep(3);
  cout << "(*)"
       << " truoc khi tang qua..tui hoi ban mot cau hoi vui nhe :3 "
       << "\n\n";
  sleep(5);
  cout << "(*)"
       << " do ban nhap dung ten cua co gai cute nhat o day la ai :3 "
       << "\n\n";
  sleep(5);

  string sname;
  cout << "=====>" << right << " nhap ten : ";
  getline(cin, sname);
  sleep(2);
  if (sname == "Nhu" || sname == "nhu")
  {
    traloidung();
    countdown();
    picture();
  }

  else
  {

    cout << '\n';

    cout << "(*)"
         << " ahihi...chia buon...:(( "
         << "\n\n";
    sleep(2);
    cout << "(*)"
         << " sai oi nha....hong dung y cua tui oi,, ;33"
         << "\n\n";
    sleep(3);
    cout << "(*)"
         << " goi y nay "
         << "\n\n";
    sleep(1);
    cout << "(*)"
         << " mot cai ten co 3 chu bat dau bang " << '\"' << "N" << '\"' << " ket thuc bang " << '\"' << "u" << '\"' << " va co chu " << '\"' << "h" << '\"' << " o giua"
         << "\n\n";
    sleep(8);
    cout << "(*)"
         << " rui tra loi lai di nao :3"
         << "\n\n";
    sleep(3);
    string snametwo;
    cout << "=====>" << right << " nhap ten: ";
    getline(cin, snametwo);
    sleep(2);
    if (snametwo == "Nhu" || snametwo == "nhu")
    {
      traloidung();
      countdown();
      picture();
    }
    else
    {

      cout << "\n";
      cout << "(*)"
           << " (0.0) sao lai tra loi the..."
           << "\n\n";
      sleep(3);
      cout << "(*)"
           << " tui goi y the cung nhap sai"
           << "\n\n";
      sleep(3);
      cout << "(*)"
           << " khong sao vi ban la mot nguoi dac biet cua nguoi tao ra tui <3"
           << "\n\n";
      sleep(6);
      cout << "(*)"
           << " tra loi lai di nao ;33"
           << "\n\n";
      sleep(3);
      cout << "(*)"
           << " Nguoi con gai supeer cuteee (~.~)"
           << "\n\n";
      sleep(3);
      string sname3;
      cout << "=====>"
           << " nhap ten: ";
      getline(cin, sname3);
      sleep(2);

      if (sname3 == "Nhu" || sname3 == "nhu")
      {
        traloidung();
        countdown();
        picture();
      }
      else
      {
        cout << '\n';
        cout << "(*)"
             << " ula...buon ba ghe di a..dj cung tra loi sai nua aaaaa "
             << "\n\n";
        sleep(5);
        cout << "(*)"
             << " thuii.. hong can ba tra loi nua dau...(o.o) "
             << "\n\n";
        sleep(4);
        cout << "(*)"
             << " hay don nhan mon qua chan thanh cua tui <3"
             << "\n\n";
        sleep(4);
        cout << "(*)"
             << "ngay bay gio :33";
        sleep(3);

        system("cls");

        countdown();
        picture();
      }
    }
  }
  system("pause");
  return 0;
}
