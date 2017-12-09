package com.company;

import java.util.Scanner;

import static java.lang.String.format;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String twenty = scan.nextLine();
if (twenty.length() < 20 ){
            twenty = String.format("%-20s", twenty).replace(' ', '*');
            System.out.println(twenty);
        }
        if (twenty.length() >20){
    twenty = twenty.substring(0, 20);
            System.out.println(twenty);
        }
    }
}