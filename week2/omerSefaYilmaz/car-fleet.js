/**
 * @param {number} target
 * @param {number[]} position
 * @param {number[]} speed
 * @return {number}
 */
var carFleet = function (target, position, speed) {
    if (position.length <= 1) {
      return position.length;
    }
    let times = position.map((pos, index) => (target - pos) / speed[index]);
    let cars = position.map((pos, index) => ({
      position: pos,
      time: times[index],
    }));
  
    cars.sort((a, b) => b.position - a.position);
  
    return countFleets(cars);
  };
  
  function countFleets(cars) {
    let fleets = 1;
    let leadTime = cars[0].time;
  
    for (let i = 1; i < cars.length; i++) {
      if (cars[i].time > leadTime) {
        fleets++;
        leadTime = cars[i].time;
      }
    }
  
    return fleets;
  }
  