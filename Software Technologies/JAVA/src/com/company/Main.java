package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String inputBool = scan.nextLine();
//        boolean checkInput = Boolean.parseBoolean(inputBool);
if ( Boolean.parseBoolean(inputBool) == true)
        System.out.println("Yes");
else
    System.out.println("No");
    }
}
