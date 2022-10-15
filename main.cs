#include<iostream>
using namespace std;
int main()
{
	int arr[5][5];
	cout << "ENTER THE MATRIX 5x5 :" << endl;
	//entering the matrix.
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			cin >> arr[i][j];
		}
	}
	cout << "THE ENTERED MATRIX :" << endl;
	//matrix before transpose.
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			cout << arr[i][j] << "  ";
		}
		cout << endl;
	}
	cout << "TRANSPOSE OF THE MATRIX :" << endl;
	//matrix after transpose.
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			cout << arr[j][i] << "  ";
		}
		cout << endl;
	}

	system("pause>0");
}
