class TimeMap:

    def __init__(self):
        self.map = {}

    def set(self, key: str, value: str, timestamp: int) -> None:
        if key not in self.map:
            self.map.update({key:[[value,timestamp]]})
        else:
            self.map[key].append([value,timestamp])

    def get(self, key: str, timestamp: int) -> str:
        if key in self.map:
            for val, time in reversed(self.map[key]):
                if time <= timestamp:
                    return val
            return ""
        else:
            return ""
