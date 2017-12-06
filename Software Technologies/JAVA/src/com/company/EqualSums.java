package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        int[] arr = Arrays.stream(new Scanner(System.in).nextLine().split("\\s"))
                .mapToInt(Integer::parseInt)
                .toArray();

        if (arr.length == 1) {
            System.out.println(0);
            return;
        }

        for (int i = 0; i < arr.length; i++) {
            int left = 0, right = 0;

            for (int j = 0; j < i; j++) {
                left += arr[j];
            }

            for (int j = i + 1; j < arr.length; j++) {
                right += arr[j];
            }

            if (left == right) {
                System.out.println(i);
                return;
            }
        }

        System.out.println("no");
    }
}