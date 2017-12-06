package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {
    public static void main(java.lang.String[] args) {

        int[] arr = Arrays.stream(new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        int count = 1, max = 1;
        List myList = new ArrayList();

        for (int i = 0; i < arr.length -1; i++) {
            if (arr[i]+1 == arr[i + 1]) {
                count++;
                myList.add(arr[i]);

            } else {
                count = 1;
            }

            if (count > max) {
                max = count;

            }
        }
        System.out.println(myList);
        for (int i = 0; i < myList.size(); i++) {
            System.out.print(i + " ");
        }

    }
}
