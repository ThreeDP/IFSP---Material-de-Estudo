// Returns the first character of the string str
var firstCharacter = function(str) {
    return str.slice(0, 1); // str.slice(0, -1) posiciona o cursor no inicio da string e retira o primeiro caracter da string
};

// Returns the last character of a string str
var lastCharacter = function(str) {
    return str.slice(-1); // str.slice(-1) retira a ultima letra da string.
};

// Returns the string that results from removing the first
//  and last characters from str
var middleCharacters = function(str) {
    return str.slice(1, -1);
};

var isPalindrome = function(str) {
    // base case #1
    if (str.length <= 1) { //str.length retorna o numero de caracteres de uma string.
        return true;
    }
    // base case #2
    if(lastCharacter(str) !== firstCharacter(str)) { // compara o se a primeira e a ultima letra da string são diferentes.
        return false;
    }
    
    // recursive case
    return isPalindrome(middleCharacters(str));
};

var checkPalindrome = function(str) {
    println("Is this word a palindrome? " + str);
    println(isPalindrome(str));
};

checkPalindrome("a");
Program.assertEqual(isPalindrome("a"), true);
checkPalindrome("motor");
Program.assertEqual(isPalindrome("motor"), false);
checkPalindrome("rotor");
Program.assertEqual(isPalindrome("rotor"), true);
