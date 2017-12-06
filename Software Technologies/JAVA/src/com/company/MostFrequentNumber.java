package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(java.lang.String[] args) {

        int[] arr = Arrays.stream(new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        System.out.println(Mode(arr));
    }
    static int Mode(int[] n){
        int t = 0;
        for(int i=0; i<n.length; i++){
            for(int j=1; j<n.length-i; j++){
                if(n[j-1] > n[j]){
                    t = n[j-1];
                    n[j-1] = n[j];
                    n[j] = t;
                }
            }
        }

        int mode = n[0];
        int temp = 1;
        int temp2 = 1;
        for(int i=1;i<n.length;i++){
            if(n[i-1] == n[i]){
                temp++;
            }
            else {
                temp = 1;
            }
            if(temp > temp2){
                mode = n[i];
                temp2 = temp;
            }

        }
        return mode;
    }
}
