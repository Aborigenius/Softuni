package com.company;
import java.util.*;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arr = Arrays.stream(scan.nextLine().split("\\s"))
                .mapToInt(Integer::parseInt).toArray();

        int[] bombParams = Arrays.stream(scan.nextLine().split("\\s"))
                .mapToInt(Integer::parseInt).toArray();
    
        int bombElement = bombParams[0];
        int bombStrength = bombParams[1];
        ArrayList<Integer> result = new ArrayList<>();

        for (int i = 0; i < arr.length; i++){
            result.add(arr[i]);
        }

        while (result.indexOf(bombElement) != -1) {
            int bombIndex = result.indexOf(bombElement);
            int bombRangeStart = Math.max(0, bombIndex - bombStrength);
            int bombRangeEnd = Math.min(bombIndex + bombStrength, result.size() - 1);

            for (int j = bombRangeStart; j <= bombRangeEnd; j++){
                result.remove(bombRangeStart);
            }
        }
        Long sum = 0L;

        for (int number: result){
            sum += number;
        }
        System.out.println(sum);

    }
}