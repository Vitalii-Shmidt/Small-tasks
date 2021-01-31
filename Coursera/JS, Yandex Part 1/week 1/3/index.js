/**
 * @param {Number} hours
 * @param {Number} minutes
 * @param {Number} interval
 * @returns {String}
 */
// interval is minutes;
// we need to increase a date on 'interval' minutes
module.exports = function(hours, minutes, interval) {
  let time = '';
  minutes += interval;
  while (minutes > 59) {
    hours += 1
    if(hours > 23) {
      hours = 0
    }
    if(minutes > 59) {
      minutes -= 60;
    }
  }
  //minutes -= 1;
  time += (hours < 10? '0' + hours : hours) + ':' +(minutes < 10?'0' + minutes : minutes);
  //console.log(time);
  return time;
};
//kek(12, 30, 30)