package com.company;

import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String url = scan.nextLine();
        String protocol = "";
        int protocolIndex = url.indexOf("://");
        if (protocolIndex > 0){
        protocol = url.substring(0, protocolIndex );
        url = url.substring(protocolIndex + 3);
        }
        String server = "";
        String resource = "";
        int serverIndex = url.indexOf("/");
        if(serverIndex < 0){
            server = url;
        }
        else {
            server = url.substring(0, serverIndex);
            resource = url.substring(serverIndex + 1);
        }
        System.out.printf("[protocol] = \"%s\"\n", protocol);
        System.out.printf("[server] = \"%s\"\n", server);
        System.out.printf("[resource] = \"%s\"\n", resource);
    }
}
