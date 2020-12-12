#include <cstdlib>
#include <iostream>
#include <vector>

using namespace std;

long long MaxPairwiseProd(const vector<int>& numbers) 
{
    long long max_prod = 0;
    int n = numbers.size();

    for (int one = 0; one < n; one++)
    {
        for (int two = one + 1; two < n; two++)
        {
            // Verifica se o produto atual do laço é maior que o maior produto até o momento gerado. E atribui á max_prod o maior produto. 
            max_prod = max(max_prod, ((long long)numbers[one]) * numbers[two]);
        }
    }
    return max_prod;
}

long long MaxPairwiseProdFast(const vector<int>& numbers)
{
    int n = numbers.size();

    int one_index = -1;
    for (int i = 0; i < n; i++)
    {
        if ((one_index == -1) || (numbers[i] > numbers[one_index]))
        {
            one_index = i;
        }
    }

    int two_index = -1;
    for (int j = 0; j < n; j++)
    {
        // Verifica se o indice é diferente do indice anterior encontrado e traz o maior numero da lista.
        if ((j != one_index) && ((two_index == -1) || (numbers[j] > numbers[two_index])))
        {
            two_index = j;
        } 
    }
    return ((long long)(numbers[one_index])) * numbers[two_index];
}

int main (void)
{
/* TESTE DE STRESS 
    while (true) 
    {
        int n = rand() % 1000 + 2;
        cout << n << "\n";
        vector<int> teste;
        for (int i = 0; i < n; i++)
        {
            teste.push_back(rand() % 100000);
        }
        for (int i = 0; i < n; i++)
        {
            cout << teste[i] << "   ";
        }
        cout << "\n\n";
        long long normal = MaxPairwiseProd(teste);
        long long speed = MaxPairwiseProdFast(teste);
        if (normal != speed) 
        {
            cout << "Wrong answer........| Normal |   | Speed |\n\n";
            cout << "                     " << normal << "       " << speed << "\n";
            break;
        }
        else 
        {
            cout << "OK ===================\n";
        }
    }
*/
    int n;
    cin >> n;
    vector<int> numbers(n);
    for (int i = 0; i < n; i++) 
    {
        cin >> numbers[i];
    }
    cout << MaxPairwiseProdFast(numbers) << "\n";
    return 0;
}
