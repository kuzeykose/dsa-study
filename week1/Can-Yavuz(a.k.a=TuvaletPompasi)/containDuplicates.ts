function containsDuplicate(nums: number[]): boolean {
    const set: Set<number> = new Set(nums);
    return set.size !== nums.length;
};