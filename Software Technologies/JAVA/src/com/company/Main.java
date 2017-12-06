package com.company;
import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        String [] words = input.split(" ");
        int[] arr = new int[words.length];

        for (int i = 0; i < arr.length; i++) {
            arr[i] = Integer.parseInt(words[i]);

        }
        Arrays.sort(arr);
        for (int i = arr.length-1; i > arr.length-4 && i >= 0 ; i--) {
            System.out.println(arr[i]);
        }

    }
}