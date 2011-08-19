/**
 * User: Adron Hall
 * Date: 8/18/11
 * Time: 3:31 PM
 * This library provides functionality to parse a time string value.
 */

var TimePiece = function(time) {

    TimePiece.Hour = function () {
        return time.toString().split(":")[0];
    }

    TimePiece.Minute = function () {
        var timeString = time.toString();
        timeString = timeString.split(":")[1];
        return timeString.substr(0, 2);
    }

    TimePiece.Meridian = function(){
        var timeString = time.toString();
        timeString = timeString.split(":")[1];
        return timeString.substr(timeString.length-2, 2).toUpperCase();
    }

    TimePiece.MilitaryHour = function () {
        if(TimePiece.Meridian()== "AM")
            return TimePiece.Hour();
        return parseInt(TimePiece.Hour()) + 12;
    };

    return null;
};
