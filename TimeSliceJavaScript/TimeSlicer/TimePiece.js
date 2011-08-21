/**
 * User: Adron Hall
 * Date: 8/18/11
 * Time: 3:31 PM
 * This library provides functionality to parse a time string value.
 */

TimePiece = function(time) {

    TimePiece.Hour = function () {
        return parseInt(time.toString().split(":")[0]);
    }

    TimePiece.Minute = function () {
        var timeString = time.toString();
        timeString = timeString.split(":")[1];
        timeString = timeString.substr(0, 2);
        return parseInt(timeString);
    }

    TimePiece.Meridian = function() {
        var timeString = time.toString();
        timeString = timeString.split(":")[1];
        timeString = timeString.substr(timeString.length - 2, 2).toUpperCase();
        return timeString;
    }

    TimePiece.MilitaryHour = function () {
        if (TimePiece.Meridian() == "AM")
            return TimePiece.Hour();
        return parseInt(TimePiece.Hour()) + 12;
    };

    return time;
};
