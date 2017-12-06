package com.company;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class IndexOfLetters {
    public static void main(java.lang.String[] args) {
//        char [] alphabet = "abcdefghijklmnopqrstuvwxyz".toCharArray();
        List list = Arrays.asList(new Character[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'});

        Scanner scan = new Scanner(System.in);
        char [] inputLetter = scan.nextLine().toCharArray();

        for (int i = 0; i < inputLetter.length; i++) {
          char javaSux =  inputLetter[i];
            System.out.printf("%s -> %d\n", inputLetter[i], (list.indexOf(javaSux)));
        }

    }
}