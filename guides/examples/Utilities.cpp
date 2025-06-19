#include <vector>
#include <set>
#include <string>

class Utilities {
public:
    static std::vector<std::string> Util1(const std::vector<std::string>& input) {
        std::set<std::string> uniqueSet(input.begin(), input.end());
        return std::vector<std::string>(uniqueSet.begin(), uniqueSet.end());
    }
};
