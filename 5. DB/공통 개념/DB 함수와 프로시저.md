


## 데이터베이스 함수 (Database Function)
데이터베이스 함수는 값을 반환하는 데 중점을 둔다.
주로 SELECT 문에서 사용되어 결과 값을 생성하고 반환한다.
반환 값이 있기 때문에 식(expression)의 일부로 사용할 수 있다. (데이터를 읽어오거나~ 읽어온데이터를 특정한 값을 반환할때)
#### SQL
```
CREATE FUNCTION 함수이름(price DECIMAL, quantity INT)
RETURNS DECIMAL
BEGIN
    RETURN price * quantity;
END;

```

## 데이터베이스 프로시저 (Database Procedure)
데이터베이스 프로시저는 값을 반환하지 않는다.
주로 데이터베이스 상태를 변경하거나 특정 작업을 수행한다.
예를 들어, 데이터를 업데이트하거나 특정 연산을 수행하는 데 사용된다. (업데이트나 인설트 사용시)

#### SQL
```
CREATE PROCEDURE 프로시저 이름(productId INT, newPrice DECIMAL)
BEGIN
    UPDATE products SET price = newPrice WHERE id = productId;
END;
```
데이터베이스에서도 함수와 프로시저의 구분은 주로 반환 값의 존재 여부에 따라 이루어 지며 >>>>>  함수는 값을 반환(o), 프로시저는 값 반환 (x)
데이터베이스에서는 특히 프로시저를 사용하여 복잡한 업무 로직을 구현하고, 함수를 사용하여 계산이나 조회와 같은 기능 사용