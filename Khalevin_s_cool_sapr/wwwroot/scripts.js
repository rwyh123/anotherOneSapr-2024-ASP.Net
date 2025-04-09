function downloadFile(fileName, contentType, base64) {
    // Создаём элемент ссылки
    const link = document.createElement("a");

    // Указываем имя файла
    link.download = fileName;

    // Устанавливаем href с данными файла
    link.href = "data:" + contentType + ";base64," + base64;

    // Добавляем ссылку в документ (временно)
    document.body.appendChild(link);

    // Эмулируем клик для начала загрузки файла
    link.click();

    // Удаляем ссылку из документа после клика
    document.body.removeChild(link);
}
