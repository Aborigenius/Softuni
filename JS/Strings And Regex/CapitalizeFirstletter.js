function capitalizeFirst(str) {
    console.log(toTitleCase(str));

    function toTitleCase(str) {
        return str.replace(/\w\S*/g, function(txt) {
            return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
        });
    }
}

capitalizeFirst('Capitalize these words');
capitalizeFirst('Was that Easy? tRY thIs onE for SiZe!');