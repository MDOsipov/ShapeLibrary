### Первое задание:
- Проект ShapeLib содержит саму библиотеку
- Проект с консольным приложением Shapes демонстрирует пример использования библиотеки
- Проект ShapeLib.test содержит unit-тесты для тестирования функционала библиотеки

### Запрос из второго задания:
	SELECT p.product_name, c.category_name 
	FROM 
		product p
		LEFT JOIN category_to_product ctp ON p.id = ctp.product_id
		LEFT JOIN category c ON c.id = ctp.category_id; 

#### Диаграмма БД:
![Диаграмма БД](C:/Users/dos12/Downloads/diagram.JPG)
