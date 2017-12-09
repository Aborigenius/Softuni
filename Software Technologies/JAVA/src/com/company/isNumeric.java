package com.company;

import java.util.Scanner;

public class isNumeric {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String s = scan.nextLine();
        if (isNumeric(s))
        {
            System.out.println("digit");
            return;
        }
        if  (isVowel(s)){
            System.out.println("vowel");
            return;
        }
        else {
            System.out.println("other");
        }

    }
    public static boolean isNumeric (String s)
    {
        return s != null && s.matches("[-+]?\\d*\\.?\\d+");
    }
    public static boolean isVowel(String s){
        return "AEIOUaeiou".indexOf(s) != -1;
    }
}
