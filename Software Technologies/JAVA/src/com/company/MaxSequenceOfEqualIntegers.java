package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualIntegers {
    public static void main(java.lang.String[] args) {

        int[] arr = Arrays.stream(new Scanner(System.in).nextLine().split(" "))
            .mapToInt(Integer::parseInt).toArray();

        int count = 1, max = 1;
        int n = arr[1];

        for (int i = 1; i < arr.length; i++) {
            if (arr[i] == arr[i - 1]) {
                count++;

            } else {
                count = 1;
            }

            if (count > max) {
                max = count;
                n = arr[i];
            }
        }
        for (int i = 0; i < max; i++) {
            System.out.print(n + " ");
        }

    }
}
