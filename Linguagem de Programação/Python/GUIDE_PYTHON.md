# Principios da Linguagem:
      
      print("Hello, World") // Saida de dados

      If X > 10:
          print("Smaller")

      while N > 10 :
          print (N)
          N = n - 1
      print('Blastoff!')
      
**Reserved Words:**

      False       class       return        is        finally
      None        if          for           lambda    continue
      True        def         from          while     nonlocal
      and         del         global        not       with
      as          elif        try           or        yield
      assert      else        import        pass      break
      except      in          raise

**Operadores Aritméticos:**

"+" adição: Menos prioritário em expressões matemáticas
    
      X = 2
      X = XX + 2
      print(X)
      4

"-" subtração: Menos prioritário em expressões matemáticas
    
      X = 10
      X = XX - 5
      print(X)
      5

"*" Multiplicação: Terceiro mais prioritário em expressões matemáticas

      X = 440 * 12
      print(X)
      5280

"/" divisão: Terceiro mais prioritário em expressões matemáticas
    
      X = 5280
      Z = X / 1000
      print(Z)
      5.28

"**" potenciação: Segundo mais prioritário em expressões matemáticas

      print(4 ** 3)
      64

"%" resto da divisão: Mais prioritário em expressões matemáticas

      X = 23
      Z = X % 5
      print(Z)
      3

**Operadores relacionais:**

"<" Menor que
      
      n = 9
      if n < 10:
            print(n)
     
"<=" Menor ou igual que
      
      n = 9
      if n <= 10:
            print(n)
            
"==" Igual á
      
      n = 10
      if n == 10:
            print(n)

">=" Maior ou igual que

      n = 5
      if n >= 5:
            print(n)
            
">" Maior que 

      n = 10
      if n > 9:
            print(n)
            
"!=" Não igual

      n = 10
      if n != 9:
            print(n)

**Condicionais**

Multiplas decisões
      
      if x < 2:
            print('Small')
      elif x < 10:
            print('Medium')
      else:
            print('Large')
      print('All done!)
      
 Traceback
      
> Traceback são mensagens que são executadas quando uma ação não pode ser executada de form correta por algum motivo. Atraves do try e do except é possivel tratar quando essas ações forem realizadas, como por exemplo, a conversão da palavra bob para uma numero inteiro e sua atribuição a uma variavel.

      astr = 'Bob'
      try:
            print('Hello')
            istr = int(astr) # Nesse momento o programa irá pular para except
            print('There')
      except:
            istr = -1
      print('Done', istr) 
            
> No caso acima o valor atribuido á astr não é um numero e por esse motivo não pode ser transformando em um inteiro, por esse motivo quando o comando é executado um traceback ocorre e o programa executa automaticamente a parte do except pulando no caso "print('there')", quando isso não ocorrer como por exemplo na atribuição de 1769 para astr o codigo dentro de try será exercutado enquando o codigo de except será ignorando.

**Entrada de dados**

      nam = input('who are you?')
      print('Welcome', nam)

### Python 2 dicas

> python 2 não gera automaticamente numeros floats em divições sendo necessário declarar os numeros com floats antes da divisão.
