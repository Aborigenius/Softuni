package com.company;

import java.util.Scanner;


public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input1 = scan.nextLine().trim().replace(" ", "");
        String input2 = scan.nextLine().trim().replace(" ", "");
        
        char [] arr1 = input1.toCharArray();
        char [] arr2 = input2.toCharArray();
        
        if (arr1.length > arr2.length){
            PrintArray(arr2);
            PrintArray(arr1);
            return;
        }
        if (arr1.length < arr2.length){
            PrintArray(arr1);
            PrintArray(arr2);
            return;
        }
        if (arr1.length == arr2.length){
            for (int i = 0; i < arr1.length ; i++) {
                if (arr1[i] == (arr2[i])){
//                    System.out.println("Match");
                    continue;
                }
                else {
                    if (arr1[i] > arr2[i]) {
                        PrintArray(arr2);
                        PrintArray(arr1);
                        return;
                    }
                    else{
                        PrintArray(arr1);
                        PrintArray(arr2);
                        return;
                    }
                    }
                }
            }
        PrintArray(arr1);
        PrintArray(arr2);
        }



        

    public static void PrintArray(char [] arr) {
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i]);
        }

        System.out.println();
    }
}
