package com.company;

import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String email = scan.nextLine();
        String text = scan.nextLine();

        String censored = censor(email);
        String censoredText = text.replace(email, censored);

        System.out.println(censoredText);
    }
    private static String censor(String text) {
        StringBuilder sb = new StringBuilder(text.length());
        int index = text.indexOf('@');

        for (int i = 0; i < index; i++){
            sb.append('*');
        }
        sb.append(text.substring(index));

        return sb.toString();
    }
}
