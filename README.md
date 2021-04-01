# Calculator_
Pierwszy okienkowy kalkulator
Utworzono metody sprawdzające, czy w polu znajduje się liczba oraz zabezpieczono przez trycatch. Umożliwiono uzytkownikowi 
wpisywanie liczb zmiennoprzecinkowych ze znakami '.' oraz ',' (metoda replace).

Dodano proste zabezpieczenie przed dzieleniem przez zero. 
W klasie Form1.cs stworzono sześć metod obsługujących przyciski w tym działania matematyczne +,-,*,/. 
Metody te przekazują za każdym razem jedną liczbę zapisaną jako tekst, który jest formatowany na typ
double w klasie Calc.cs. Poza tym w klasie Form1.cs dodano metodę ResetTextBox która czyści pole do wpisania liczby i ustawia w nim kursor.

