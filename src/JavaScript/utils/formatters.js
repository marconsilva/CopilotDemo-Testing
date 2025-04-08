// This file exports functions for formatting data, such as FormatDate and FormatCurrency.

export function FormatDate(date) {
    return new Intl.DateTimeFormat('en-US').format(date);
}

export function FormatCurrency(amount) {
    return new Intl.NumberFormat('en-US', { style: 'currency', currency: 'USD' }).format(amount);
}