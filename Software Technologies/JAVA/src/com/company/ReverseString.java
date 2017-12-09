package com.company;

import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String reverseMe = scan.nextLine();

       String reversed = new StringBuilder(reverseMe).reverse().toString();
        System.out.println(reversed);
    }
}