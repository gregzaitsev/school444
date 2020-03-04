class FibCounter {
    public int[] GetNumbers(int n) {
        int[] ret = new int[n];
        ret[0] = 1;
        ret[1] = 2;
        for (int i=2; i<n; i++) {
            ret[i] = ret[i-1] + ret[i-2];
        }
        return ret;
    }
}
