function escape(arr) {
    let result = '<ul>\n';
    for (let text of arr) {
        result += `  <li>${htmlEscape(text)}</li>\n`;

    }
    console.log(result + '</ul>');

    function htmlEscape(str) {
        return str.replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }

}

escape(['<b>unescaped text</b>', 'normal text']);