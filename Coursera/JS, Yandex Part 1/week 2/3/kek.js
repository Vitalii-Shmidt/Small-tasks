// Телефонная книга
const phoneBook = {};

// Главная функция, в пределах которой мы свитчимся по команде и, соответственно, выполняем их,
// вызывая функции с конкретным типом команды
function main(command) {
    const commandType = command.split(' ')[0];

    if(commandType === 'REMOVE') {
        const phone = command.split(' ')[1];
        removePhone(phone);
    } else if(commandType === 'SHOW') {
        showInfo();
    } else if(commandType === 'ADD') {
        const contact = command.split(' ')[1];
        const phones = command.split(' ')[2];
        addContact(contact, phones);
    }

}
main('ADD Ivan 0991841855,0956003890,06618428488,88005553535');



// Добавляет контакт в телефонную книгу со списком телефонов. Телефоны перечисляются через запятую.
// Если такой контакт существует, то команда пополняет список телефонов контакта.
function addContact(contact, phones) {
    if(!phoneBook.includes(contact)) {
        phoneBook.push(contact);
    }
    contact += phones.join(',');
    console.log(contact);
}


// Удаляет телефон из телефонной книги. Если телефон успешно удалён, то функция должна вернуть true.
// Если такого телефона в телефонной книге не существует, то возвращается false.
function removePhone(phone) {
    if(!phoneBook.includes(phone)) {
        return false;
    }
    delete phoneBook.phone;
    return true;
}


// Возвращает массив контактов с их телефонами. Массив содержит строчки вида: "Имя: Телефон1, Телефон2". Массив должен быть отсортирован по имени контакта. Телефоны идут в порядке добавления их в телефонную книгу.
// Контакт с пустым списком телефонов не должен возвращаться.
function showInfo() {
    console.log(phoneBook);
}