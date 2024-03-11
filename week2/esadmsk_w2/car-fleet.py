class Solution(object):
    def carFleet(self, target, position, speed):
        cars = sorted(zip(position, speed), reverse=True)
        fleets = 0
        time_to_reach_target = [float(target - p) / s for p, s in cars]
        curr_max = 0

        for time in time_to_reach_target:
            if time > curr_max:
                curr_max = time
                fleets += 1

        return fleets
