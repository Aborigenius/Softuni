package com.company;

import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        int x = Integer.parseInt(input);

        String hex = Integer.toHexString(x).toUpperCase();
        String binary = Integer.toBinaryString(x);

        System.out.println(hex);
        System.out.println(binary);
    }
}
