#include <iostream>
#include <vector>
#include <string>
#include "Utilities.cpp"

int main() {
    std::vector<std::string> input = {"apple", "banana", "apple", "orange", "banana"};
    std::vector<std::string> result = Utilities::Util1(input);

    std::cout << "重複除去後のリスト:" << std::endl;
    for (const auto& str : result) {
        std::cout << str << std::endl;
    }
    return 0;
}