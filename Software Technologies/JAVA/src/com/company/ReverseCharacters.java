package com.company;

import java.lang.reflect.Array;
import java.util.*;

public class ReverseCharacters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        ArrayList<String> list = new ArrayList<String>();
        for (int i = 0; i < 3; i++) {
            String input = scan.nextLine();
            list.add(input);
        }
        Collections.reverse(list);
    String printMeForFuckSake = list.toString()
            .replace(",", "")
            .replace("[", "")
            .replace("]", "")
            .replace(" ", "")
            .trim();

        System.out.println(printMeForFuckSake);

    }
}
