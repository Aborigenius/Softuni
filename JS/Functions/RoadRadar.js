"use strict";

function speedCheck([speed, area]) {
    speed = Number(speed);
    let limit = getLimit(area);
    let violation = (getViolation(speed, limit));
    if (violation) {
        console.log(violation);
    }

    function getLimit(area) {
        switch (area) {
            case 'motorway':
                return 130;
            case 'interstate':
                return 90;
            case 'city':
                return 50;
            case 'residential':
                return 20;
        }
    }

    function getViolation(speed, limit) {
        let overspeed = speed - limit;
        if (overspeed <= 0) {
            return false;
        } else {
            if (overspeed >= 1 && overspeed <= 20) {
                return 'speeding';
            } else if (overspeed > 20 && overspeed <= 40) {
                return 'excessive speeding';
            } else {
                return 'reckless driving';
            }
        }

    }

}


speedCheck([21, 'residential']);
speedCheck([40, 'city']);
speedCheck([120, 'interstate']);
speedCheck([200, 'motorway']);