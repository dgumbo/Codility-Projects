package com.denzilgumbo.codility.lessons._02_arrays;

import java.util.ArrayList;
import java.util.List;

public class OddOccurrencesInArray {

    public static void main(String[] args) {
        OddOccurrencesInArray ps = new OddOccurrencesInArray();

        //int[] A = new int[]{73, 7, 4, 7, 2, 6, 7, 2, 7, 73, 9, 7, 7};
       // int[] A = new int[]{9, 7, 7};
        int[] A = new int[]{9, 3, 9, 3, 9, 7, 9};

        System.out.println("OddOccurrencesInArray : " + ps.solution(A));
    }

    public int solution(int[] A) {
        // write your code in Java SE 8   
        if (A.length == 0) {
            return 0;
        }
        if (A.length == 1) {
            return A[0];
        }

        List<Integer> B = new ArrayList();

        for (int i = 0; i < A.length; i++) {

            int iCurrent = A[i];

            if (B.contains(iCurrent)) {
                B.remove(B.indexOf(iCurrent));
            } else {
                B.add(iCurrent);
            }
        }

        return B.get(0);
    }
}
