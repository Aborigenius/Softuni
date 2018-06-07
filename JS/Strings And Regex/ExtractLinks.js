function linkExtractor(arr) {
    let result = [];
    let regex = /www\.[A-Za-z0-9\-]+(\.[a-z]+)+/g;
    let match = regex.exec(arr);
    while (match) {
        result.push(match[0]);
        match = regex.exec(arr);

    }
    console.log(result.join('\n'));
}

linkExtractor(['Join WebStars now for free, at www.web-stars.com',
    'You can also support our partners',
    'Internet - www.internet.com',
    'WebSpiders - www.webspiders101.com',
    'Sentinel - www.sentinel.-ko',
]);

///www\.[A-Za-z0-9\-]+(\.[a-z]+)+/g;