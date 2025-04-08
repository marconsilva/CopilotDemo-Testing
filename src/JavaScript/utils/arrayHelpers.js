// This file exports utility functions for array manipulation, such as FilterUnique and SortArray.

function FilterUnique(array) {
    return [...new Set(array)];
}

function SortArray(array) {
    return array.slice().sort((a, b) => a - b);
}

module.exports = {
    FilterUnique,
    SortArray
};